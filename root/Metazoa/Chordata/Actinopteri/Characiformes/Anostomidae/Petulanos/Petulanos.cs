using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Petulanos;

/// <summary>
/// Abstract class for Petulanos (genus).
/// NCBI TaxId: 2499846
/// </summary>
public abstract class Petulanos : Anostomidae, IPetulanos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petulanos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499846;

    /// <inheritdoc />
    public virtual string GenusName => "Petulanos";

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
