using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Grafisia;

/// <summary>
/// Abstract class for Grafisia (genus).
/// NCBI TaxId: 451440
/// </summary>
public abstract class Grafisia : Sturnidae, IGrafisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grafisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451440;

    /// <inheritdoc />
    public virtual string GenusName => "Grafisia";

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
