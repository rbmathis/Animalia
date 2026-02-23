using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Dysalotus;

/// <summary>
/// Abstract class for Dysalotus (genus).
/// NCBI TaxId: 270549
/// </summary>
public abstract class Dysalotus : Chiasmodontidae, IDysalotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dysalotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270549;

    /// <inheritdoc />
    public virtual string GenusName => "Dysalotus";

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
