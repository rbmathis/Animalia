using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Ditropichthys;

/// <summary>
/// Abstract class for Ditropichthys (genus).
/// NCBI TaxId: 114853
/// </summary>
public abstract class Ditropichthys : Cetomimidae, IDitropichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ditropichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114853;

    /// <inheritdoc />
    public virtual string GenusName => "Ditropichthys";

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
