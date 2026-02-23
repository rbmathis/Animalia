using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Elassomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Elassomatidae.Elassoma;

/// <summary>
/// Abstract class for Elassoma (genus).
/// NCBI TaxId: 71673
/// </summary>
public abstract class Elassoma : Elassomatidae, IElassoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elassoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71673;

    /// <inheritdoc />
    public virtual string GenusName => "Elassoma";

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
