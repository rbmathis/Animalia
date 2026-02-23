using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Anostomoides;

/// <summary>
/// Abstract class for Anostomoides (genus).
/// NCBI TaxId: 2499840
/// </summary>
public abstract class Anostomoides : Anostomidae, IAnostomoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anostomoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499840;

    /// <inheritdoc />
    public virtual string GenusName => "Anostomoides";

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
