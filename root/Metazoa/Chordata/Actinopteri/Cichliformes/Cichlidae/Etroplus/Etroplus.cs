using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Etroplus;

/// <summary>
/// Abstract class for Etroplus (genus).
/// NCBI TaxId: 50795
/// </summary>
public abstract class Etroplus : Cichlidae, IEtroplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Etroplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50795;

    /// <inheritdoc />
    public virtual string GenusName => "Etroplus";

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
