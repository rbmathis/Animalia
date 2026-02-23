using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Dussumieriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Dussumieriidae.Dussumieria;

/// <summary>
/// Abstract class for Dussumieria (genus).
/// NCBI TaxId: 365063
/// </summary>
public abstract class Dussumieria : Dussumieriidae, IDussumieria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dussumieria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365063;

    /// <inheritdoc />
    public virtual string GenusName => "Dussumieria";

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
