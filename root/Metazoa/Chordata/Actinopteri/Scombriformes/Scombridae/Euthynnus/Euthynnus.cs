using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Euthynnus;

/// <summary>
/// Abstract class for Euthynnus (genus).
/// NCBI TaxId: 8225
/// </summary>
public abstract class Euthynnus : Scombridae, IEuthynnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euthynnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8225;

    /// <inheritdoc />
    public virtual string GenusName => "Euthynnus";

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
