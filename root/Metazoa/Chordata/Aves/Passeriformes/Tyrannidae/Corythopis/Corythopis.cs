using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Corythopis;

/// <summary>
/// Abstract class for Corythopis (genus).
/// NCBI TaxId: 183329
/// </summary>
public abstract class Corythopis : Tyrannidae, ICorythopis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corythopis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183329;

    /// <inheritdoc />
    public virtual string GenusName => "Corythopis";

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
