using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Balaenicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Balaenicipitidae.Balaeniceps;

/// <summary>
/// Abstract class for Balaeniceps (genus).
/// NCBI TaxId: 33583
/// </summary>
public abstract class Balaeniceps : Balaenicipitidae, IBalaeniceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balaeniceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33583;

    /// <inheritdoc />
    public virtual string GenusName => "Balaeniceps";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
