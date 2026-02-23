using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Schismatogobius;

/// <summary>
/// Abstract class for Schismatogobius (genus).
/// NCBI TaxId: 1366314
/// </summary>
public abstract class Schismatogobius : Gobiidae, ISchismatogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schismatogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1366314;

    /// <inheritdoc />
    public virtual string GenusName => "Schismatogobius";

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
