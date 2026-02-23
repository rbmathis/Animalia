using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Photolateralis;

/// <summary>
/// Abstract class for Photolateralis (genus).
/// NCBI TaxId: 1891637
/// </summary>
public abstract class Photolateralis : Leiognathidae, IPhotolateralis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photolateralis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1891637;

    /// <inheritdoc />
    public virtual string GenusName => "Photolateralis";

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
