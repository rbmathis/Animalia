using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Scorpiodoras;

/// <summary>
/// Abstract class for Scorpiodoras (genus).
/// NCBI TaxId: 1312667
/// </summary>
public abstract class Scorpiodoras : Doradidae, IScorpiodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpiodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312667;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpiodoras";

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
