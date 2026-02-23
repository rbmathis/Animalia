using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Viduidae.Anomalospiza;

/// <summary>
/// Abstract class for Anomalospiza (genus).
/// NCBI TaxId: 187416
/// </summary>
public abstract class Anomalospiza : Viduidae, IAnomalospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomalospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187416;

    /// <inheritdoc />
    public virtual string GenusName => "Anomalospiza";

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
