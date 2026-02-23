using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Trachyscorpia;

/// <summary>
/// Abstract class for Trachyscorpia (genus).
/// NCBI TaxId: 274694
/// </summary>
public abstract class Trachyscorpia : Sebastidae, ITrachyscorpia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyscorpia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274694;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyscorpia";

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
