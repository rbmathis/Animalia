using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Barbourula;

/// <summary>
/// Abstract class for Barbourula (genus).
/// NCBI TaxId: 877556
/// </summary>
public abstract class Barbourula : Bombinatoridae, IBarbourula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbourula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 877556;

    /// <inheritdoc />
    public virtual string GenusName => "Barbourula";

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
