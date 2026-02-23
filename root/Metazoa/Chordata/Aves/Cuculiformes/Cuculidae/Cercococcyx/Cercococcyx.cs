using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Cercococcyx;

/// <summary>
/// Abstract class for Cercococcyx (genus).
/// NCBI TaxId: 78200
/// </summary>
public abstract class Cercococcyx : Cuculidae, ICercococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78200;

    /// <inheritdoc />
    public virtual string GenusName => "Cercococcyx";

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
