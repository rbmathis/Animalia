using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetomimus;

/// <summary>
/// Abstract class for Cetomimus (genus).
/// NCBI TaxId: 88667
/// </summary>
public abstract class Cetomimus : Cetomimidae, ICetomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88667;

    /// <inheritdoc />
    public virtual string GenusName => "Cetomimus";

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
