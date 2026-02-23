using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittrichas;

/// <summary>
/// Abstract class for Psittrichas (genus).
/// NCBI TaxId: 57433
/// </summary>
public abstract class Psittrichas : Psittacidae, IPsittrichas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittrichas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57433;

    /// <inheritdoc />
    public virtual string GenusName => "Psittrichas";

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
