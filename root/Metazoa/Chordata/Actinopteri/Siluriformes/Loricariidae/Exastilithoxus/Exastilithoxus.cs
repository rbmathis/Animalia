using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Exastilithoxus;

/// <summary>
/// Abstract class for Exastilithoxus (genus).
/// NCBI TaxId: 1633170
/// </summary>
public abstract class Exastilithoxus : Loricariidae, IExastilithoxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exastilithoxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633170;

    /// <inheritdoc />
    public virtual string GenusName => "Exastilithoxus";

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
