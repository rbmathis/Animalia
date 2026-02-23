using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Ameiva;

/// <summary>
/// Abstract class for Ameiva (genus).
/// NCBI TaxId: 8533
/// </summary>
public abstract class Ameiva : Teiidae, IAmeiva
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ameiva";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8533;

    /// <inheritdoc />
    public virtual string GenusName => "Ameiva";

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
