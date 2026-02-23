using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Odonteleotris;

/// <summary>
/// Abstract class for Odonteleotris (genus).
/// NCBI TaxId: 1365699
/// </summary>
public abstract class Odonteleotris : Eleotridae, IOdonteleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odonteleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365699;

    /// <inheritdoc />
    public virtual string GenusName => "Odonteleotris";

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
