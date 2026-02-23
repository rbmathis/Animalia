using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aurivela;

/// <summary>
/// Abstract class for Aurivela (genus).
/// NCBI TaxId: 1392236
/// </summary>
public abstract class Aurivela : Teiidae, IAurivela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aurivela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392236;

    /// <inheritdoc />
    public virtual string GenusName => "Aurivela";

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
