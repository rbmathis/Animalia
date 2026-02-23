using AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Megadyptes;

/// <summary>
/// Abstract class for Megadyptes (genus).
/// NCBI TaxId: 37084
/// </summary>
public abstract class Megadyptes : Spheniscidae, IMegadyptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megadyptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37084;

    /// <inheritdoc />
    public virtual string GenusName => "Megadyptes";

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
