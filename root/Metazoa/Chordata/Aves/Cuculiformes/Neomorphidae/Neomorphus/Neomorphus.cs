using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Neomorphus;

/// <summary>
/// Abstract class for Neomorphus (genus).
/// NCBI TaxId: 78207
/// </summary>
public abstract class Neomorphus : Neomorphidae, INeomorphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomorphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78207;

    /// <inheritdoc />
    public virtual string GenusName => "Neomorphus";

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
