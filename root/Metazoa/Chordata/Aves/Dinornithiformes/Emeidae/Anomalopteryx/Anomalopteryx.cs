using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Anomalopteryx;

/// <summary>
/// Abstract class for Anomalopteryx (genus).
/// NCBI TaxId: 8810
/// </summary>
public abstract class Anomalopteryx : Emeidae, IAnomalopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8810;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalopteryx";

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
