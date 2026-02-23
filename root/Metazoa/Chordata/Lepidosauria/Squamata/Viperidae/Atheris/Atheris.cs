using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Atheris;

/// <summary>
/// Abstract class for Atheris (genus).
/// NCBI TaxId: 110215
/// </summary>
public abstract class Atheris : Viperidae, IAtheris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atheris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110215;

    /// <inheritdoc />
    public virtual string GenusName => "Atheris";

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
