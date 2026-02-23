using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Nematolebias;

/// <summary>
/// Abstract class for Nematolebias (genus).
/// NCBI TaxId: 942014
/// </summary>
public abstract class Nematolebias : Rivulidae, INematolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942014;

    /// <inheritdoc />
    public virtual string GenusName => "Nematolebias";

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
