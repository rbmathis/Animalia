using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Barbuligobius;

/// <summary>
/// Abstract class for Barbuligobius (genus).
/// NCBI TaxId: 2057081
/// </summary>
public abstract class Barbuligobius : Gobiidae, IBarbuligobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbuligobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2057081;

    /// <inheritdoc />
    public virtual string GenusName => "Barbuligobius";

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
