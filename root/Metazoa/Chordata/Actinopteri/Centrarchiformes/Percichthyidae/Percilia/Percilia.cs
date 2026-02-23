using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Percilia;

/// <summary>
/// Abstract class for Percilia (genus).
/// NCBI TaxId: 270587
/// </summary>
public abstract class Percilia : Percichthyidae, IPercilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270587;

    /// <inheritdoc />
    public virtual string GenusName => "Percilia";

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
