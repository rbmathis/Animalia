using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae.Elops;

/// <summary>
/// Abstract class for Elops (genus).
/// NCBI TaxId: 7927
/// </summary>
public abstract class Elops : Elopidae, IElops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7927;

    /// <inheritdoc />
    public virtual string GenusName => "Elops";

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
