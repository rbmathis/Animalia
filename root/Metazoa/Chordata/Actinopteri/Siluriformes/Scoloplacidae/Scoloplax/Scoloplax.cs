using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Scoloplacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Scoloplacidae.Scoloplax;

/// <summary>
/// Abstract class for Scoloplax (genus).
/// NCBI TaxId: 390389
/// </summary>
public abstract class Scoloplax : Scoloplacidae, IScoloplax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scoloplax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390389;

    /// <inheritdoc />
    public virtual string GenusName => "Scoloplax";

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
