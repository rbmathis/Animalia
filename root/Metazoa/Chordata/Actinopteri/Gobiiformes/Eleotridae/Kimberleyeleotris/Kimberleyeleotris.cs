using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Kimberleyeleotris;

/// <summary>
/// Abstract class for Kimberleyeleotris (genus).
/// NCBI TaxId: 1365691
/// </summary>
public abstract class Kimberleyeleotris : Eleotridae, IKimberleyeleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kimberleyeleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365691;

    /// <inheritdoc />
    public virtual string GenusName => "Kimberleyeleotris";

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
