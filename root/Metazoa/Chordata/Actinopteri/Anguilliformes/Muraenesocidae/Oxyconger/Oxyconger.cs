using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenesocidae.Oxyconger;

/// <summary>
/// Abstract class for Oxyconger (genus).
/// NCBI TaxId: 189502
/// </summary>
public abstract class Oxyconger : Muraenesocidae, IOxyconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189502;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyconger";

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
