using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Procetichthys;

/// <summary>
/// Abstract class for Procetichthys (genus).
/// NCBI TaxId: 565080
/// </summary>
public abstract class Procetichthys : Cetomimidae, IProcetichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procetichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 565080;

    /// <inheritdoc />
    public virtual string GenusName => "Procetichthys";

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
