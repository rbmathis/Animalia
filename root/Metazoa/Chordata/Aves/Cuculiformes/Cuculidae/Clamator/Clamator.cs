using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Clamator;

/// <summary>
/// Abstract class for Clamator (genus).
/// NCBI TaxId: 78202
/// </summary>
public abstract class Clamator : Cuculidae, IClamator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clamator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78202;

    /// <inheritdoc />
    public virtual string GenusName => "Clamator";

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
