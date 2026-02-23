using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Luvaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Luvaridae.Luvarus;

/// <summary>
/// Abstract class for Luvarus (genus).
/// NCBI TaxId: 75025
/// </summary>
public abstract class Luvarus : Luvaridae, ILuvarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luvarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75025;

    /// <inheritdoc />
    public virtual string GenusName => "Luvarus";

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
