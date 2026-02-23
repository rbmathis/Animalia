using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lophotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lophotidae.Eumecichthys;

/// <summary>
/// Abstract class for Eumecichthys (genus).
/// NCBI TaxId: 1263184
/// </summary>
public abstract class Eumecichthys : Lophotidae, IEumecichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumecichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263184;

    /// <inheritdoc />
    public virtual string GenusName => "Eumecichthys";

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
