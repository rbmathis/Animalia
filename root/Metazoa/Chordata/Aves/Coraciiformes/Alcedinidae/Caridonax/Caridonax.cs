using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Caridonax;

/// <summary>
/// Abstract class for Caridonax (genus).
/// NCBI TaxId: 2049299
/// </summary>
public abstract class Caridonax : Alcedinidae, ICaridonax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caridonax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2049299;

    /// <inheritdoc />
    public virtual string GenusName => "Caridonax";

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
