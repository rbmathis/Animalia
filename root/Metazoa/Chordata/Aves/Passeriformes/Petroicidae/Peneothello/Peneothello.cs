using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Peneothello;

/// <summary>
/// Abstract class for Peneothello (genus).
/// NCBI TaxId: 254639
/// </summary>
public abstract class Peneothello : Petroicidae, IPeneothello
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peneothello";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254639;

    /// <inheritdoc />
    public virtual string GenusName => "Peneothello";

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
