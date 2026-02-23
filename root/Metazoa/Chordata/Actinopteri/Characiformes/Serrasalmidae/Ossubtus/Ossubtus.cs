using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Ossubtus;

/// <summary>
/// Abstract class for Ossubtus (genus).
/// NCBI TaxId: 138553
/// </summary>
public abstract class Ossubtus : Serrasalmidae, IOssubtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ossubtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138553;

    /// <inheritdoc />
    public virtual string GenusName => "Ossubtus";

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
