using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Orinocodoras;

/// <summary>
/// Abstract class for Orinocodoras (genus).
/// NCBI TaxId: 157063
/// </summary>
public abstract class Orinocodoras : Doradidae, IOrinocodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orinocodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 157063;

    /// <inheritdoc />
    public virtual string GenusName => "Orinocodoras";

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
