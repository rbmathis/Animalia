using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Trachydoras;

/// <summary>
/// Abstract class for Trachydoras (genus).
/// NCBI TaxId: 238632
/// </summary>
public abstract class Trachydoras : Doradidae, ITrachydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238632;

    /// <inheritdoc />
    public virtual string GenusName => "Trachydoras";

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
