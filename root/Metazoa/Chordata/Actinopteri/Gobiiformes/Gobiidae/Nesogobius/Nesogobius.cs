using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Nesogobius;

/// <summary>
/// Abstract class for Nesogobius (genus).
/// NCBI TaxId: 1776235
/// </summary>
public abstract class Nesogobius : Gobiidae, INesogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1776235;

    /// <inheritdoc />
    public virtual string GenusName => "Nesogobius";

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
