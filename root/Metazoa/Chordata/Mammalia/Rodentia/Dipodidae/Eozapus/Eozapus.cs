using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Eozapus;

/// <summary>
/// Abstract class for Eozapus (genus).
/// NCBI TaxId: 101672
/// </summary>
public abstract class Eozapus : Dipodidae, IEozapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eozapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101672;

    /// <inheritdoc />
    public virtual string GenusName => "Eozapus";

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
