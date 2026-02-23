using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Adelotus;

/// <summary>
/// Abstract class for Adelotus (genus).
/// NCBI TaxId: 104074
/// </summary>
public abstract class Adelotus : Limnodynastidae, IAdelotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 104074;

    /// <inheritdoc />
    public virtual string GenusName => "Adelotus";

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
