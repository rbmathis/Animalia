using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Epigonichthys;

/// <summary>
/// Abstract class for Epigonichthys (genus).
/// NCBI TaxId: 30273
/// </summary>
public abstract class Epigonichthys : Branchiostomatidae, IEpigonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epigonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30273;

    /// <inheritdoc />
    public virtual string GenusName => "Epigonichthys";

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
