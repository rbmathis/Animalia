using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Caproiformes.Caproidae.Capros;

/// <summary>
/// Abstract class for Capros (genus).
/// NCBI TaxId: 206099
/// </summary>
public abstract class Capros : Caproidae, ICapros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206099;

    /// <inheritdoc />
    public virtual string GenusName => "Capros";

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
