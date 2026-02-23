using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Hildebrandtia;

/// <summary>
/// Abstract class for Hildebrandtia (genus).
/// NCBI TaxId: 127629
/// </summary>
public abstract class Hildebrandtia : Ptychadenidae, IHildebrandtia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hildebrandtia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127629;

    /// <inheritdoc />
    public virtual string GenusName => "Hildebrandtia";

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
