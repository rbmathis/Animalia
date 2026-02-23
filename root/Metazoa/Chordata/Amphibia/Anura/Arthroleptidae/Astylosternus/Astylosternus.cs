using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Astylosternus;

/// <summary>
/// Abstract class for Astylosternus (genus).
/// NCBI TaxId: 111119
/// </summary>
public abstract class Astylosternus : Arthroleptidae, IAstylosternus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astylosternus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111119;

    /// <inheritdoc />
    public virtual string GenusName => "Astylosternus";

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
