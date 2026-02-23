using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Astur;

/// <summary>
/// Abstract class for Astur (genus).
/// NCBI TaxId: 3410462
/// </summary>
public abstract class Astur : Accipitridae, IAstur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410462;

    /// <inheritdoc />
    public virtual string GenusName => "Astur";

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
