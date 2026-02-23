using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiodynastes;

/// <summary>
/// Abstract class for Myiodynastes (genus).
/// NCBI TaxId: 371927
/// </summary>
public abstract class Myiodynastes : Tyrannidae, IMyiodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 371927;

    /// <inheritdoc />
    public virtual string GenusName => "Myiodynastes";

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
