using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dentectus;

/// <summary>
/// Abstract class for Dentectus (genus).
/// NCBI TaxId: 3016011
/// </summary>
public abstract class Dentectus : Loricariidae, IDentectus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dentectus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3016011;

    /// <inheritdoc />
    public virtual string GenusName => "Dentectus";

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
