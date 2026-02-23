using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Cacatua;

/// <summary>
/// Abstract class for Cacatua (genus).
/// NCBI TaxId: 12981
/// </summary>
public abstract class Cacatua : Cacatuidae, ICacatua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacatua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 12981;

    /// <inheritdoc />
    public virtual string GenusName => "Cacatua";

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
