using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena;

/// <summary>
/// Abstract class for Coryphaena (genus).
/// NCBI TaxId: 13453
/// </summary>
public abstract class Coryphaena : Coryphaenidae, ICoryphaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13453;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphaena";

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
