using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Macrocephalon;

/// <summary>
/// Abstract class for Macrocephalon (genus).
/// NCBI TaxId: 177177
/// </summary>
public abstract class Macrocephalon : Megapodiidae, IMacrocephalon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrocephalon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 177177;

    /// <inheritdoc />
    public virtual string GenusName => "Macrocephalon";

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
