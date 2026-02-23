using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Typhleotris;

/// <summary>
/// Abstract class for Typhleotris (genus).
/// NCBI TaxId: 1230366
/// </summary>
public abstract class Typhleotris : Eleotridae, ITyphleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230366;

    /// <inheritdoc />
    public virtual string GenusName => "Typhleotris";

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
