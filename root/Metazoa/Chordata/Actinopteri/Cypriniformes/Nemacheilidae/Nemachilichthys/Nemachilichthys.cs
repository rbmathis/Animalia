using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Nemachilichthys;

/// <summary>
/// Abstract class for Nemachilichthys (genus).
/// NCBI TaxId: 1758143
/// </summary>
public abstract class Nemachilichthys : Nemacheilidae, INemachilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemachilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1758143;

    /// <inheritdoc />
    public virtual string GenusName => "Nemachilichthys";

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
