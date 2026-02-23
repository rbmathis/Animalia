using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leucos;

/// <summary>
/// Abstract class for Leucos (genus).
/// NCBI TaxId: 2562968
/// </summary>
public abstract class Leucos : Leuciscidae, ILeucos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2562968;

    /// <inheritdoc />
    public virtual string GenusName => "Leucos";

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
