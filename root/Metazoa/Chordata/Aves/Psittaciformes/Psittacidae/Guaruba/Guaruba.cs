using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Guaruba;

/// <summary>
/// Abstract class for Guaruba (genus).
/// NCBI TaxId: 51905
/// </summary>
public abstract class Guaruba : Psittacidae, IGuaruba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guaruba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51905;

    /// <inheritdoc />
    public virtual string GenusName => "Guaruba";

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
