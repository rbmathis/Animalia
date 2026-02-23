using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Leucosoma;

/// <summary>
/// Abstract class for Leucosoma (genus).
/// NCBI TaxId: 240827
/// </summary>
public abstract class Leucosoma : Salangidae, ILeucosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240827;

    /// <inheritdoc />
    public virtual string GenusName => "Leucosoma";

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
