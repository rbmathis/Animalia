using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Satrapa;

/// <summary>
/// Abstract class for Satrapa (genus).
/// NCBI TaxId: 495238
/// </summary>
public abstract class Satrapa : Tyrannidae, ISatrapa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Satrapa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495238;

    /// <inheritdoc />
    public virtual string GenusName => "Satrapa";

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
